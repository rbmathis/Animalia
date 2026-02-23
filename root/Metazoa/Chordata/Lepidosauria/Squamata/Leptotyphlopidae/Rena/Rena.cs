using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Leptotyphlopidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Leptotyphlopidae.Rena;

/// <summary>
/// Abstract class for Rena (genus).
/// NCBI TaxId: 711326
/// </summary>
public abstract class Rena : Leptotyphlopidae, IRena
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rena";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 711326;

    /// <inheritdoc />
    public virtual string GenusName => "Rena";

    /// <inheritdoc />
    public virtual string[] GenusCharacteristics => new[]
    {
        "Large body size",
        "Social pack structure",
        "Complex hunting strategies",
        "Highly developed olfaction",
        "Territorial behavior"
    };

    /// <inheritdoc />
    public virtual bool CanInterbreed => true;

}

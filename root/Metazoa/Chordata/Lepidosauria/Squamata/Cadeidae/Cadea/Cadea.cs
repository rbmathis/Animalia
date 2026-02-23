using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Cadeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Cadeidae.Cadea;

/// <summary>
/// Abstract class for Cadea (genus).
/// NCBI TaxId: 493903
/// </summary>
public abstract class Cadea : Cadeidae, ICadea
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cadea";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 493903;

    /// <inheritdoc />
    public virtual string GenusName => "Cadea";

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

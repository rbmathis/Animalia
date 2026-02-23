using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Iguanidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Iguanidae.Microlophus;

/// <summary>
/// Abstract class for Microlophus (genus).
/// NCBI TaxId: 179258
/// </summary>
public abstract class Microlophus : Iguanidae, IMicrolophus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Microlophus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 179258;

    /// <inheritdoc />
    public virtual string GenusName => "Microlophus";

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

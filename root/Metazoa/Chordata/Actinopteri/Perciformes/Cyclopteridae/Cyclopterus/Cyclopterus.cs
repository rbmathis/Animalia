using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cyclopteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cyclopteridae.Cyclopterus;

/// <summary>
/// Abstract class for Cyclopterus (genus).
/// NCBI TaxId: 8102
/// </summary>
public abstract class Cyclopterus : Cyclopteridae, ICyclopterus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cyclopterus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8102;

    /// <inheritdoc />
    public virtual string GenusName => "Cyclopterus";

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

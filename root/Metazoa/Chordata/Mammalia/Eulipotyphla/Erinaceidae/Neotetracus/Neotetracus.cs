using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Erinaceidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Erinaceidae.Neotetracus;

/// <summary>
/// Abstract class for Neotetracus (genus).
/// NCBI TaxId: 977877
/// </summary>
public abstract class Neotetracus : Erinaceidae, INeotetracus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Neotetracus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 977877;

    /// <inheritdoc />
    public virtual string GenusName => "Neotetracus";

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

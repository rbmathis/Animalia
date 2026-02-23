using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Gasteropelecidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Gasteropelecidae.Gasteropelecus;

/// <summary>
/// Abstract class for Gasteropelecus (genus).
/// NCBI TaxId: 42498
/// </summary>
public abstract class Gasteropelecus : Gasteropelecidae, IGasteropelecus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gasteropelecus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 42498;

    /// <inheritdoc />
    public virtual string GenusName => "Gasteropelecus";

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

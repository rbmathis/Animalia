using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Dactylopteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Dactylopteridae.Dactylopterus;

/// <summary>
/// Abstract class for Dactylopterus (genus).
/// NCBI TaxId: 94923
/// </summary>
public abstract class Dactylopterus : Dactylopteridae, IDactylopterus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dactylopterus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 94923;

    /// <inheritdoc />
    public virtual string GenusName => "Dactylopterus";

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

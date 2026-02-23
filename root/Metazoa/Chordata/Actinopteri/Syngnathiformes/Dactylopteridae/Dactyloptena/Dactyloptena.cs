using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Dactylopteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Dactylopteridae.Dactyloptena;

/// <summary>
/// Abstract class for Dactyloptena (genus).
/// NCBI TaxId: 143341
/// </summary>
public abstract class Dactyloptena : Dactylopteridae, IDactyloptena
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dactyloptena";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 143341;

    /// <inheritdoc />
    public virtual string GenusName => "Dactyloptena";

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

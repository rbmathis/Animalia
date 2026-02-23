using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Perciformes_incertae_sedis.Pataecidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Perciformes_incertae_sedis.Pataecidae.Aetapcus;

/// <summary>
/// Abstract class for Aetapcus (genus).
/// NCBI TaxId: 274721
/// </summary>
public abstract class Aetapcus : Pataecidae, IAetapcus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aetapcus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 274721;

    /// <inheritdoc />
    public virtual string GenusName => "Aetapcus";

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

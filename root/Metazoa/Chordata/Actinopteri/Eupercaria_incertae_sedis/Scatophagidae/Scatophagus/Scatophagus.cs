using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Scatophagidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Scatophagidae.Scatophagus;

/// <summary>
/// Abstract class for Scatophagus (genus).
/// NCBI TaxId: 75037
/// </summary>
public abstract class Scatophagus : Scatophagidae, IScatophagus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Scatophagus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 75037;

    /// <inheritdoc />
    public virtual string GenusName => "Scatophagus";

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

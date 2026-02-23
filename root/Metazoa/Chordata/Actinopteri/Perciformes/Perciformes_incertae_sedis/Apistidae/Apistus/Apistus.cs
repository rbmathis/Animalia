using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Perciformes_incertae_sedis.Apistidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Perciformes_incertae_sedis.Apistidae.Apistus;

/// <summary>
/// Abstract class for Apistus (genus).
/// NCBI TaxId: 990931
/// </summary>
public abstract class Apistus : Apistidae, IApistus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Apistus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 990931;

    /// <inheritdoc />
    public virtual string GenusName => "Apistus";

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

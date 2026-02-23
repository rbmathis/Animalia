using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Serrasalmidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Serrasalmidae.Myloplus;

/// <summary>
/// Abstract class for Myloplus (genus).
/// NCBI TaxId: 443197
/// </summary>
public abstract class Myloplus : Serrasalmidae, IMyloplus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Myloplus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 443197;

    /// <inheritdoc />
    public virtual string GenusName => "Myloplus";

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

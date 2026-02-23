using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gymnotiformes.Apteronotidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gymnotiformes.Apteronotidae.Compsaraia;

/// <summary>
/// Abstract class for Compsaraia (genus).
/// NCBI TaxId: 597350
/// </summary>
public abstract class Compsaraia : Apteronotidae, ICompsaraia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Compsaraia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 597350;

    /// <inheritdoc />
    public virtual string GenusName => "Compsaraia";

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

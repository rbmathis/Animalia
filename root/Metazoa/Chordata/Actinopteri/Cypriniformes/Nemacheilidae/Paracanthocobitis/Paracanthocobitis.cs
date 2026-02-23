using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Nemacheilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Nemacheilidae.Paracanthocobitis;

/// <summary>
/// Abstract class for Paracanthocobitis (genus).
/// NCBI TaxId: 1690646
/// </summary>
public abstract class Paracanthocobitis : Nemacheilidae, IParacanthocobitis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Paracanthocobitis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1690646;

    /// <inheritdoc />
    public virtual string GenusName => "Paracanthocobitis";

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

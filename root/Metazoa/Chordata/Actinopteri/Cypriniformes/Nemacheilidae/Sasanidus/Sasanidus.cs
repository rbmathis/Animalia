using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Nemacheilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Nemacheilidae.Sasanidus;

/// <summary>
/// Abstract class for Sasanidus (genus).
/// NCBI TaxId: 1843390
/// </summary>
public abstract class Sasanidus : Nemacheilidae, ISasanidus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sasanidus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1843390;

    /// <inheritdoc />
    public virtual string GenusName => "Sasanidus";

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

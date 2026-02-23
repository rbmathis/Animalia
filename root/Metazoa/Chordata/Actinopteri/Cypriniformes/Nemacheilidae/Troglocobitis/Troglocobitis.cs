using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Nemacheilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Nemacheilidae.Troglocobitis;

/// <summary>
/// Abstract class for Troglocobitis (genus).
/// NCBI TaxId: 2964546
/// </summary>
public abstract class Troglocobitis : Nemacheilidae, ITroglocobitis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Troglocobitis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2964546;

    /// <inheritdoc />
    public virtual string GenusName => "Troglocobitis";

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

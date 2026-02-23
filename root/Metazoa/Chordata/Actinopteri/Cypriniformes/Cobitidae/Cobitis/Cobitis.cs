using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cobitidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cobitidae.Cobitis;

/// <summary>
/// Abstract class for Cobitis (genus).
/// NCBI TaxId: 47718
/// </summary>
public abstract class Cobitis : Cobitidae, ICobitis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cobitis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 47718;

    /// <inheritdoc />
    public virtual string GenusName => "Cobitis";

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

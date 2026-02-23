using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cobitidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cobitidae.Microcobitis;

/// <summary>
/// Abstract class for Microcobitis (genus).
/// NCBI TaxId: 1396446
/// </summary>
public abstract class Microcobitis : Cobitidae, IMicrocobitis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Microcobitis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1396446;

    /// <inheritdoc />
    public virtual string GenusName => "Microcobitis";

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

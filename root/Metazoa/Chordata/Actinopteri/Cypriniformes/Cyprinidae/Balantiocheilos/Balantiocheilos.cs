using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Balantiocheilos;

/// <summary>
/// Abstract class for Balantiocheilos (genus).
/// NCBI TaxId: 369626
/// </summary>
public abstract class Balantiocheilos : Cyprinidae, IBalantiocheilos
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Balantiocheilos";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 369626;

    /// <inheritdoc />
    public virtual string GenusName => "Balantiocheilos";

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

using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Nemacheilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Nemacheilidae.Sectoria;

/// <summary>
/// Abstract class for Sectoria (genus).
/// NCBI TaxId: 341096
/// </summary>
public abstract class Sectoria : Nemacheilidae, ISectoria
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sectoria";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 341096;

    /// <inheritdoc />
    public virtual string GenusName => "Sectoria";

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

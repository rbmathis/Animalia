using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Nemacheilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Nemacheilidae.Mustura;

/// <summary>
/// Abstract class for Mustura (genus).
/// NCBI TaxId: 2892044
/// </summary>
public abstract class Mustura : Nemacheilidae, IMustura
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mustura";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2892044;

    /// <inheritdoc />
    public virtual string GenusName => "Mustura";

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

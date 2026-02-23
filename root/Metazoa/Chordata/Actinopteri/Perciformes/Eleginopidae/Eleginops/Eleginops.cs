using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Eleginopidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Eleginopidae.Eleginops;

/// <summary>
/// Abstract class for Eleginops (genus).
/// NCBI TaxId: 56732
/// </summary>
public abstract class Eleginops : Eleginopidae, IEleginops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Eleginops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 56732;

    /// <inheritdoc />
    public virtual string GenusName => "Eleginops";

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

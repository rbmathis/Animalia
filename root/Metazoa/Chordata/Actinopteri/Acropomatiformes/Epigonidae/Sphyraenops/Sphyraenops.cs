using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Epigonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Epigonidae.Sphyraenops;

/// <summary>
/// Abstract class for Sphyraenops (genus).
/// NCBI TaxId: 1960913
/// </summary>
public abstract class Sphyraenops : Epigonidae, ISphyraenops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sphyraenops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1960913;

    /// <inheritdoc />
    public virtual string GenusName => "Sphyraenops";

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

using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Agonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Agonidae.Aspidophoroides;

/// <summary>
/// Abstract class for Aspidophoroides (genus).
/// NCBI TaxId: 255536
/// </summary>
public abstract class Aspidophoroides : Agonidae, IAspidophoroides
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aspidophoroides";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 255536;

    /// <inheritdoc />
    public virtual string GenusName => "Aspidophoroides";

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

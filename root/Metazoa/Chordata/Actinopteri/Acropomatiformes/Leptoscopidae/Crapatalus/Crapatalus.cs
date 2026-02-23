using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Leptoscopidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Leptoscopidae.Crapatalus;

/// <summary>
/// Abstract class for Crapatalus (genus).
/// NCBI TaxId: 1703793
/// </summary>
public abstract class Crapatalus : Leptoscopidae, ICrapatalus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Crapatalus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1703793;

    /// <inheritdoc />
    public virtual string GenusName => "Crapatalus";

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

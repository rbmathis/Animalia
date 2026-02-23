using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Elacatinus;

/// <summary>
/// Abstract class for Elacatinus (genus).
/// NCBI TaxId: 203289
/// </summary>
public abstract class Elacatinus : Gobiidae, IElacatinus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Elacatinus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 203289;

    /// <inheritdoc />
    public virtual string GenusName => "Elacatinus";

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

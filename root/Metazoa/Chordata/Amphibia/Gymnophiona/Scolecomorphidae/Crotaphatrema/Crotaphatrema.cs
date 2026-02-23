using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Gymnophiona.Scolecomorphidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Gymnophiona.Scolecomorphidae.Crotaphatrema;

/// <summary>
/// Abstract class for Crotaphatrema (genus).
/// NCBI TaxId: 356292
/// </summary>
public abstract class Crotaphatrema : Scolecomorphidae, ICrotaphatrema
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Crotaphatrema";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 356292;

    /// <inheritdoc />
    public virtual string GenusName => "Crotaphatrema";

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

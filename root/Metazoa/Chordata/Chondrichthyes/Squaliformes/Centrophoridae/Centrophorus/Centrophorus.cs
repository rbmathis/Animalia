using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Squaliformes.Centrophoridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Squaliformes.Centrophoridae.Centrophorus;

/// <summary>
/// Abstract class for Centrophorus (genus).
/// NCBI TaxId: 212736
/// </summary>
public abstract class Centrophorus : Centrophoridae, ICentrophorus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Centrophorus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 212736;

    /// <inheritdoc />
    public virtual string GenusName => "Centrophorus";

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

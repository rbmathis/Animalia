using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Timaliidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Timaliidae.Oxylabes;

/// <summary>
/// Abstract class for Oxylabes (genus).
/// NCBI TaxId: 98143
/// </summary>
public abstract class Oxylabes : Timaliidae, IOxylabes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Oxylabes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 98143;

    /// <inheritdoc />
    public virtual string GenusName => "Oxylabes";

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

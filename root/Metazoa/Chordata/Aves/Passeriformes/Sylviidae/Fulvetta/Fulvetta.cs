using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sylviidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sylviidae.Fulvetta;

/// <summary>
/// Abstract class for Fulvetta (genus).
/// NCBI TaxId: 2029310
/// </summary>
public abstract class Fulvetta : Sylviidae, IFulvetta
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Fulvetta";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2029310;

    /// <inheritdoc />
    public virtual string GenusName => "Fulvetta";

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

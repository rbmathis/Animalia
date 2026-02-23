using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sylviidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sylviidae.Sylvietta;

/// <summary>
/// Abstract class for Sylvietta (genus).
/// NCBI TaxId: 208068
/// </summary>
public abstract class Sylvietta : Sylviidae, ISylvietta
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sylvietta";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 208068;

    /// <inheritdoc />
    public virtual string GenusName => "Sylvietta";

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

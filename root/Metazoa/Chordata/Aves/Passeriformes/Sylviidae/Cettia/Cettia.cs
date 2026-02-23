using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sylviidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sylviidae.Cettia;

/// <summary>
/// Abstract class for Cettia (genus).
/// NCBI TaxId: 36271
/// </summary>
public abstract class Cettia : Sylviidae, ICettia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cettia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 36271;

    /// <inheritdoc />
    public virtual string GenusName => "Cettia";

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

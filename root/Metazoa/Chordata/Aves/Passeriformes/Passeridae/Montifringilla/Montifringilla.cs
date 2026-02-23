using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Passeridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Passeridae.Montifringilla;

/// <summary>
/// Abstract class for Montifringilla (genus).
/// NCBI TaxId: 221975
/// </summary>
public abstract class Montifringilla : Passeridae, IMontifringilla
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Montifringilla";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 221975;

    /// <inheritdoc />
    public virtual string GenusName => "Montifringilla";

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

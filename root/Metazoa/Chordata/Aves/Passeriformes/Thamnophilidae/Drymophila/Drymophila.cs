using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thamnophilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thamnophilidae.Drymophila;

/// <summary>
/// Abstract class for Drymophila (genus).
/// NCBI TaxId: 88168
/// </summary>
public abstract class Drymophila : Thamnophilidae, IDrymophila
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Drymophila";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 88168;

    /// <inheritdoc />
    public virtual string GenusName => "Drymophila";

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

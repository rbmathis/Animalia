using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Certhiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Certhiidae.Uropsila;

/// <summary>
/// Abstract class for Uropsila (genus).
/// NCBI TaxId: 376344
/// </summary>
public abstract class Uropsila : Certhiidae, IUropsila
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Uropsila";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 376344;

    /// <inheritdoc />
    public virtual string GenusName => "Uropsila";

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

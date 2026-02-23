using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Aleadryas;

/// <summary>
/// Abstract class for Aleadryas (genus).
/// NCBI TaxId: 461237
/// </summary>
public abstract class Aleadryas : Passeriformes, IAleadryas
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aleadryas";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 461237;

    /// <inheritdoc />
    public virtual string GenusName => "Aleadryas";

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

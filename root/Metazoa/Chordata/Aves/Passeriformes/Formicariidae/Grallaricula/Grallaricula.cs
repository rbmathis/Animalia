using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Formicariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Formicariidae.Grallaricula;

/// <summary>
/// Abstract class for Grallaricula (genus).
/// NCBI TaxId: 117175
/// </summary>
public abstract class Grallaricula : Formicariidae, IGrallaricula
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Grallaricula";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 117175;

    /// <inheritdoc />
    public virtual string GenusName => "Grallaricula";

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

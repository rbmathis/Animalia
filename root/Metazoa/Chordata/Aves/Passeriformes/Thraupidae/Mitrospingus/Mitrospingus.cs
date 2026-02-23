using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae.Mitrospingus;

/// <summary>
/// Abstract class for Mitrospingus (genus).
/// NCBI TaxId: 62219
/// </summary>
public abstract class Mitrospingus : Thraupidae, IMitrospingus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mitrospingus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 62219;

    /// <inheritdoc />
    public virtual string GenusName => "Mitrospingus";

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

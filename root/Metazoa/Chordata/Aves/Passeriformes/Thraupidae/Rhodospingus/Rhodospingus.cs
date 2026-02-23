using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae.Rhodospingus;

/// <summary>
/// Abstract class for Rhodospingus (genus).
/// NCBI TaxId: 664764
/// </summary>
public abstract class Rhodospingus : Thraupidae, IRhodospingus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rhodospingus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 664764;

    /// <inheritdoc />
    public virtual string GenusName => "Rhodospingus";

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

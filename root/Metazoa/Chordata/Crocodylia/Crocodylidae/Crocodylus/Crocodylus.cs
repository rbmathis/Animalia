using AnimalKingdom.root.Metazoa.Chordata.Crocodylia.Crocodylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Crocodylia.Crocodylidae.Crocodylus;

/// <summary>
/// Abstract class for Crocodylus (genus).
/// NCBI TaxId: 8500
/// </summary>
public abstract class Crocodylus : Crocodylidae, ICrocodylus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Crocodylus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8500;

    /// <inheritdoc />
    public virtual string GenusName => "Crocodylus";

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

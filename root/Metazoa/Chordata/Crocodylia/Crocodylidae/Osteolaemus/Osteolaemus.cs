using AnimalKingdom.root.Metazoa.Chordata.Crocodylia.Crocodylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Crocodylia.Crocodylidae.Osteolaemus;

/// <summary>
/// Abstract class for Osteolaemus (genus).
/// NCBI TaxId: 184241
/// </summary>
public abstract class Osteolaemus : Crocodylidae, IOsteolaemus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Osteolaemus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 184241;

    /// <inheritdoc />
    public virtual string GenusName => "Osteolaemus";

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

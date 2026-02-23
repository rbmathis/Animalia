using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Meliphagidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Meliphagidae.Certhionyx;

/// <summary>
/// Abstract class for Certhionyx (genus).
/// NCBI TaxId: 266340
/// </summary>
public abstract class Certhionyx : Meliphagidae, ICerthionyx
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Certhionyx";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 266340;

    /// <inheritdoc />
    public virtual string GenusName => "Certhionyx";

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

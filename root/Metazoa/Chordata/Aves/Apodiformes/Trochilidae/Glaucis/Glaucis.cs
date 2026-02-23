using AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae.Glaucis;

/// <summary>
/// Abstract class for Glaucis (genus).
/// NCBI TaxId: 190456
/// </summary>
public abstract class Glaucis : Trochilidae, IGlaucis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Glaucis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 190456;

    /// <inheritdoc />
    public virtual string GenusName => "Glaucis";

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

using AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Polytelis;

/// <summary>
/// Abstract class for Polytelis (genus).
/// NCBI TaxId: 35544
/// </summary>
public abstract class Polytelis : Psittacidae, IPolytelis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Polytelis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 35544;

    /// <inheritdoc />
    public virtual string GenusName => "Polytelis";

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

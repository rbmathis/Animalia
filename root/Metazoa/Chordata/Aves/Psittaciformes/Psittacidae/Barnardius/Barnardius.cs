using AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Barnardius;

/// <summary>
/// Abstract class for Barnardius (genus).
/// NCBI TaxId: 286723
/// </summary>
public abstract class Barnardius : Psittacidae, IBarnardius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Barnardius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 286723;

    /// <inheritdoc />
    public virtual string GenusName => "Barnardius";

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

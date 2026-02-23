using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Petroicidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Petroicidae.Microeca;

/// <summary>
/// Abstract class for Microeca (genus).
/// NCBI TaxId: 254555
/// </summary>
public abstract class Microeca : Petroicidae, IMicroeca
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Microeca";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 254555;

    /// <inheritdoc />
    public virtual string GenusName => "Microeca";

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

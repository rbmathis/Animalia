using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Petroicidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Petroicidae.Devioeca;

/// <summary>
/// Abstract class for Devioeca (genus).
/// NCBI TaxId: 3150810
/// </summary>
public abstract class Devioeca : Petroicidae, IDevioeca
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Devioeca";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3150810;

    /// <inheritdoc />
    public virtual string GenusName => "Devioeca";

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

using AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Stolidobranchia.Molgulidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Stolidobranchia.Molgulidae.Bostrichobranchus;

/// <summary>
/// Abstract class for Bostrichobranchus (genus).
/// NCBI TaxId: 30287
/// </summary>
public abstract class Bostrichobranchus : Molgulidae, IBostrichobranchus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bostrichobranchus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 30287;

    /// <inheritdoc />
    public virtual string GenusName => "Bostrichobranchus";

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

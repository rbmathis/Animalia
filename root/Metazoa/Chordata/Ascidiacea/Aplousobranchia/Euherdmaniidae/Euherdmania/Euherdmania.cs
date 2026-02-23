using AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Aplousobranchia.Euherdmaniidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Aplousobranchia.Euherdmaniidae.Euherdmania;

/// <summary>
/// Abstract class for Euherdmania (genus).
/// NCBI TaxId: 2795861
/// </summary>
public abstract class Euherdmania : Euherdmaniidae, IEuherdmania
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Euherdmania";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2795861;

    /// <inheritdoc />
    public virtual string GenusName => "Euherdmania";

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

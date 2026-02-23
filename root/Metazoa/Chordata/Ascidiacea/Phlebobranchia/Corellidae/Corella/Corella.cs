using AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Phlebobranchia.Corellidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Phlebobranchia.Corellidae.Corella;

/// <summary>
/// Abstract class for Corella (genus).
/// NCBI TaxId: 111869
/// </summary>
public abstract class Corella : Corellidae, ICorella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Corella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 111869;

    /// <inheritdoc />
    public virtual string GenusName => "Corella";

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

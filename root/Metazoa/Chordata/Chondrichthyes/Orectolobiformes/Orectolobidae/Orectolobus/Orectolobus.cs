using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Orectolobiformes.Orectolobidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Orectolobiformes.Orectolobidae.Orectolobus;

/// <summary>
/// Abstract class for Orectolobus (genus).
/// NCBI TaxId: 168097
/// </summary>
public abstract class Orectolobus : Orectolobidae, IOrectolobus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Orectolobus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 168097;

    /// <inheritdoc />
    public virtual string GenusName => "Orectolobus";

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

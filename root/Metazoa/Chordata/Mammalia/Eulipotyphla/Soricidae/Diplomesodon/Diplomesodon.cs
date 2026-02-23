using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Soricidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Soricidae.Diplomesodon;

/// <summary>
/// Abstract class for Diplomesodon (genus).
/// NCBI TaxId: 458328
/// </summary>
public abstract class Diplomesodon : Soricidae, IDiplomesodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Diplomesodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 458328;

    /// <inheritdoc />
    public virtual string GenusName => "Diplomesodon";

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

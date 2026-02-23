using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Soricidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Soricidae.Ruwenzorisorex;

/// <summary>
/// Abstract class for Ruwenzorisorex (genus).
/// NCBI TaxId: 150085
/// </summary>
public abstract class Ruwenzorisorex : Soricidae, IRuwenzorisorex
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ruwenzorisorex";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 150085;

    /// <inheritdoc />
    public virtual string GenusName => "Ruwenzorisorex";

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

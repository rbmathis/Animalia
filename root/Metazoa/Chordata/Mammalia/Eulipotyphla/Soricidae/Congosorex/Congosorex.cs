using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Soricidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Soricidae.Congosorex;

/// <summary>
/// Abstract class for Congosorex (genus).
/// NCBI TaxId: 150110
/// </summary>
public abstract class Congosorex : Soricidae, ICongosorex
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Congosorex";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 150110;

    /// <inheritdoc />
    public virtual string GenusName => "Congosorex";

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

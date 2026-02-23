using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Soricidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Soricidae.Solisorex;

/// <summary>
/// Abstract class for Solisorex (genus).
/// NCBI TaxId: 1174665
/// </summary>
public abstract class Solisorex : Soricidae, ISolisorex
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Solisorex";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1174665;

    /// <inheritdoc />
    public virtual string GenusName => "Solisorex";

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

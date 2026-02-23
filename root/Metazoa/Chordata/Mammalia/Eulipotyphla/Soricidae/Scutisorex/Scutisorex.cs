using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Soricidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Soricidae.Scutisorex;

/// <summary>
/// Abstract class for Scutisorex (genus).
/// NCBI TaxId: 150087
/// </summary>
public abstract class Scutisorex : Soricidae, IScutisorex
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Scutisorex";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 150087;

    /// <inheritdoc />
    public virtual string GenusName => "Scutisorex";

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

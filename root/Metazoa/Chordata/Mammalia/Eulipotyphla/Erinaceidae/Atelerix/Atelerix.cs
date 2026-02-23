using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Erinaceidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Erinaceidae.Atelerix;

/// <summary>
/// Abstract class for Atelerix (genus).
/// NCBI TaxId: 9367
/// </summary>
public abstract class Atelerix : Erinaceidae, IAtelerix
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Atelerix";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9367;

    /// <inheritdoc />
    public virtual string GenusName => "Atelerix";

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

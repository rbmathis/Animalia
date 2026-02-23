using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Scandentia.Tupaiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Scandentia.Tupaiidae.Ptilocercus;

/// <summary>
/// Abstract class for Ptilocercus (genus).
/// NCBI TaxId: 320337
/// </summary>
public abstract class Ptilocercus : Tupaiidae, IPtilocercus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ptilocercus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 320337;

    /// <inheritdoc />
    public virtual string GenusName => "Ptilocercus";

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

using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sylviidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sylviidae.Cholornis;

/// <summary>
/// Abstract class for Cholornis (genus).
/// NCBI TaxId: 2485339
/// </summary>
public abstract class Cholornis : Sylviidae, ICholornis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cholornis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2485339;

    /// <inheritdoc />
    public virtual string GenusName => "Cholornis";

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

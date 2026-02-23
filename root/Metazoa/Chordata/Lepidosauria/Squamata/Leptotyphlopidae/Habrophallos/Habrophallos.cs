using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Leptotyphlopidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Leptotyphlopidae.Habrophallos;

/// <summary>
/// Abstract class for Habrophallos (genus).
/// NCBI TaxId: 3148935
/// </summary>
public abstract class Habrophallos : Leptotyphlopidae, IHabrophallos
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Habrophallos";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3148935;

    /// <inheritdoc />
    public virtual string GenusName => "Habrophallos";

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

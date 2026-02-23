using AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Laridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Laridae.Chroicocephalus;

/// <summary>
/// Abstract class for Chroicocephalus (genus).
/// NCBI TaxId: 1129741
/// </summary>
public abstract class Chroicocephalus : Laridae, IChroicocephalus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chroicocephalus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1129741;

    /// <inheritdoc />
    public virtual string GenusName => "Chroicocephalus";

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

using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Xenocyprididae.Xenocypridinae_incertae_sedis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Xenocyprididae.Xenocypridinae_incertae_sedis.Anabarilius;

/// <summary>
/// Abstract class for Anabarilius (genus).
/// NCBI TaxId: 495549
/// </summary>
public abstract class Anabarilius : Xenocypridinae_incertae_sedis, IAnabarilius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Anabarilius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 495549;

    /// <inheritdoc />
    public virtual string GenusName => "Anabarilius";

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

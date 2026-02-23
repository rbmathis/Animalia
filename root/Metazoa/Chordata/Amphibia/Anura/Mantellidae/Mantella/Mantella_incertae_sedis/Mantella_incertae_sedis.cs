using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Mantellidae.Mantella;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Mantellidae.Mantella.Mantella_incertae_sedis;

/// <summary>
/// Abstract class for Mantella incertae sedis (no rank).
/// NCBI TaxId: 2689241
/// </summary>
public abstract class Mantella_incertae_sedis : Mantella, IMantella_incertae_sedis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mantella incertae sedis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2689241;

    /// <inheritdoc />
    public virtual string Description => "Taxon: Mantella_incertae_sedis";
}
